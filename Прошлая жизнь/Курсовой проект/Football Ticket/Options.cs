using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Football_Ticket
{
    class Options
    {
        public static ftEntities1 db = new ftEntities1();
        public static List<employer> workers;
        public static List<match> matches;
        public static List<team> teams;
        public static List<places> ps;
        public static List<ticket> ts;
        public static string role;
        public static string name;
        public static string patronymic;
        public string CheckUser(string l, string p)
        {
            workers = (from emps in db.employer select emps).ToList();
            int count = 0;
            foreach (var emps in workers)
            {
                if ((emps.login == l) && (emps.password == p))
                {
                    count++;
                    role = emps.role;
                    name = emps.name;
                    patronymic = emps.patronymic;
                }
            }
            if (count == 0)
            {
                return "ошибка";
            }
            else return role;
        }
        public string HelloMessage()
        {
            if ((role == "оператор базы данных") || (role == "администратор"))
            {
                string h_m = "С возвращением, " + name + " " + patronymic + "! Удачной работы!";
                return h_m;
            }
            else return "";
        }
        public void ShowMatches(DataGridView dgv)
        {
            matches = (from m in db.match select m).ToList();
            var query = (from m in matches
                         join t in db.team on m.team_id equals t.team_id
                         orderby m.match_id
                         select new { m.match_id, t.name, m.type, m.date_match }).ToList();
            dgv.DataSource = query;
            dgv.ReadOnly = true;
            dgv.Columns[0].HeaderText = "Код матча";
            dgv.Columns[1].HeaderText = "Команда соперника";
            dgv.Columns[2].HeaderText = "Тип соревнования";
            dgv.Columns[3].HeaderText = "Дата матча";
        }
        public void ShowTeams(DataGridView dgv)
        {
            teams = (from t in db.team select t).ToList();
            var query = (from t in teams
                         orderby t.team_id
                         select new { t.team_id, t.name, t.city }).ToList();
            dgv.DataSource = query;
            dgv.ReadOnly = true;
            dgv.Columns[0].HeaderText = "Код команды";
            dgv.Columns[1].HeaderText = "Название команды";
            dgv.Columns[2].HeaderText = "Город";
        }
        public void ShowWorkers(DataGridView dgv)
        {
            var query = (from w in db.employer
                         orderby w.emp_id
                         select new {w.emp_id, w.surname,w.name,w.patronymic,w.login,w.password,w.role}).ToList();
            dgv.DataSource = query;
            dgv.ReadOnly = true;
            dgv.Columns[0].Visible = false;
            dgv.Columns[1].HeaderText = "Фамилия";
            dgv.Columns[2].HeaderText = "Имя";
            dgv.Columns[3].HeaderText = "Отчество";
            dgv.Columns[4].HeaderText = "Логин";
            dgv.Columns[5].HeaderText = "Пароль";
            dgv.Columns[6].HeaderText = "Роль";
        }
        public void AddTeam(string new_name, string new_city)
        {
            int number_team = db.team.Max(n => n.team_id) + 1;
            team new_team = new team { team_id = number_team, name = new_name, city = new_city };
            db.team.Add(new_team);
            db.SaveChanges();
            teams = db.team.OrderBy(o => o.team_id).ToList();
        }
        public List<string> List_team()
        {
            var query = (from g in db.team orderby g.team_id
                         where g.team_id!=1
                         select g.name).ToList();
            return query;
        }
        public void AddMatch(int t, string new_type, DateTime new_date)
        {
            int number_match;
            if (db.match.Count() == 0) number_match = 1;
            else number_match = db.match.Max(n => n.match_id) + 1;
            match new_match = new match { match_id = number_match, team_id = t, type = new_type, date_match = new_date };
            db.match.Add(new_match);
            db.SaveChanges();
            matches = db.match.OrderBy(o => o.match_id).ToList();
        }
        public void AddWorker(string s,string n,string p,string l,string pw,string r)
        {
            int number_w;
            if (db.employer.Count() == 0) number_w = 1;
            else number_w = db.employer.Max(we => we.emp_id) + 1;
            employer new_emp = new employer {surname=s,name=n,patronymic=p,login=l,password=pw,role=r };
            db.employer.Add(new_emp);
            db.SaveChanges();
        }
        public static team item;
        public  List<string> ChooseTeam(DataGridView dgv)
        {
            List<team> query = (from t in db.team select t).ToList();
            item = query.First(w => w.team_id.ToString() == dgv.SelectedCells[0].OwningRow.Cells[0].Value.ToString());
            List<string> l = new List<string>();
            l.Add(item.name);
            l.Add(item.city);
            return l;
        }
        public static match item2;
        public List<string> ChooseMatch(DataGridView dgv)
        {
            List<match> query = (from t in db.match select t).ToList();
            item2 = query.First(w => w.match_id.ToString() == dgv.SelectedCells[0].OwningRow.Cells[0].Value.ToString());
            List<string> l2 = new List<string>();
            l2.Add(item2.team_id.ToString());
            l2.Add(item2.type);
            l2.Add(item2.date_match.ToString());
            return l2;
        }
        public static employer item3;
        public List<string> ChooseWorker (DataGridView dgv)
        {
            List<employer> query = (from t in db.employer select t).ToList();
            List<string> l3 = new List<string>();
            item3 = query.First(w => w.emp_id.ToString() == dgv.SelectedCells[0].OwningRow.Cells[0].Value.ToString());
            l3.Add(item3.surname);
            l3.Add(item3.name);
            l3.Add(item3.patronymic);
            l3.Add(item3.login);
            l3.Add(item3.password);
            l3.Add(item3.role);
            return l3;
        }
        public static employer item4;
        public List<string> ChooseWorker2(DataGridView dgv)
        {
            List<employer> query = (from t in db.employer select t).ToList();
            item4 = query.First(w => w.emp_id.ToString() == dgv.SelectedCells[0].OwningRow.Cells[0].Value.ToString());
            List<string> l4 = new List<string>();
            l4.Add(item4.surname);
            l4.Add(item4.name);
            l4.Add(item4.patronymic);
            l4.Add(item4.role);
            return l4;
        }
        public void  DeleteW()
        {
            var result = db.employer.SingleOrDefault(d => d.emp_id == item4.emp_id);
            result.login = "";
            result.password = "";
            result.role = "";
            db.SaveChanges();
        }
        public List<int> MatchesT()
        {
            return (from m in db.match where m.date_match > DateTime.Now select m.match_id).ToList();
        }
        
        public void EditTeam(string t1, string t2)
        {
            var result = db.team.SingleOrDefault(w => w.team_id == item.team_id);
            result.name = t1;
            result.city = t2;
            db.SaveChanges();
            teams = db.team.OrderBy(o => o.team_id).ToList();
        }
        public void EditMatch(int n,string t,DateTime date)
        {
            var result = db.match.SingleOrDefault(w => w.match_id == item2.match_id);
            result.team_id = n;
            result.type = t;
            result.date_match = date; 
            db.SaveChanges();
        }
        public void EditWorker(string s, string n, string p, string l, string pw, string r)
        {
            var result = db.employer.SingleOrDefault(w => w.emp_id == item3.emp_id);
            result.surname = s;
            result.name = n;
            result.patronymic = p;
            result.login = l;
            result.password = pw;
            result.role = r;
            db.SaveChanges();
        }
        public string[] SoonMatches(int i)
        {
            var query = (from m in db.match
                         join t in db.team on m.team_id equals t.team_id
                         where m.date_match>DateTime.Now
                         orderby m.date_match
                         select new { m.match_id,m.type,m.date_match,t.name,t.city}).ToList();
            int max = query.Count();
            string[] str= new string[4];
            if (i >= max)
            {
                str[0]= "Матч недоступен";
            }
            else
            {
                str[0] = query[i].match_id.ToString();
                str[1] = query[i].type;
                str[2] = query[i].date_match.ToLongDateString() + " " + query[i].date_match.ToShortTimeString();
                str[3]=" Рубин (Казань) - " + query[i].name + " (" + query[i].city + ")";
            }
            return str;
        }
        public float cost = 0;
        public string BuyTicket(int id_match,int num_sec,int num_row,int num_pl,string type_tick,bool abon,int emp_code)
        {
            if (id_match == 0) abon = true;
            if ((num_sec < 6) || (num_sec > 31)) cost += 150;
            if (((num_sec > 5)&&(num_sec < 15))||((num_sec>22)&&(num_sec<32))) cost += 50;
            if ((num_sec >14) && (num_sec < 23)) cost += 100;
            if (num_row == 3) cost += 50;
            if (num_row == 6) cost += 1500;
            if (abon == true) cost = 10000;
            int number_pl;
            if (db.places.Count() == 0) number_pl = 1;
            else number_pl = db.places.Max(n => n.place_id) + 1;
            if (abon == false)
            {
                places new_pl = new places { place_id = number_pl, match_id = id_match, sector = num_sec, row = num_row, num_place = num_pl, type = type_tick, season_ticket = abon, price = cost };
                db.places.Add(new_pl);
                db.SaveChanges();
                ps = db.places.OrderBy(o => o.place_id).ToList();
                int number_t;
                if (db.ticket.Count() == 0) number_t = 1;
                else number_t = db.ticket.Max(n => n.ticket_id) + 1;
                ticket new_t = new ticket { ticket_id = number_t, place_id = number_pl, emp_id = emp_code };
                db.ticket.Add(new_t);
                db.SaveChanges();
                ts = db.ticket.OrderBy(o => o.ticket_id).ToList();

                return "Вы приобрели билет на матч. С вас " + cost + " рублей. Оплатите в кассе";
            }
            else
            {
                var query2 = (from m in db.match
                              where m.date_match > DateTime.Now
                              orderby m.date_match
                              select m.match_id).ToList();
                int number_t;
                for (int i=0;i<query2.Count;i++)
                {
                    places new_pl = new places { place_id = number_pl, match_id = query2[i], sector = num_sec, row = num_row, num_place = num_pl, type = type_tick, season_ticket = abon, price = cost };
                    db.places.Add(new_pl);
                    db.SaveChanges();
                    ps = db.places.OrderBy(o => o.place_id).ToList();
                    if (db.ticket.Count() == 0) number_t = 1;
                    else number_t = db.ticket.Max(n => n.ticket_id) + 1;
                    ticket new_t = new ticket { ticket_id = number_t, place_id = number_pl, emp_id = emp_code };
                    db.ticket.Add(new_t);
                    db.SaveChanges();
                    ts = db.ticket.OrderBy(o => o.ticket_id).ToList();
                    number_pl++;
                    number_t++;
                }
                return "Вы приобрели абонемент на сезон. С вас " + cost + " рублей. Оплатите в кассе";
            }
        }
        public void DeletePlace(int match_num, int num_sec, int num_row, int num_pl)
        {
            var delete_id =(from p in db.places
                                    where (p.match_id == match_num)&&(p.sector==num_sec)&&(p.row==num_row)&&(p.num_place==num_pl)
                                    select p.place_id).ToList();
            var dlt = delete_id[0];
            var delete_ticket=(from t in db.ticket
                              where t.place_id==dlt
                              select t).First();
            var delete_pl = (from t in db.places
                                 where t.place_id == dlt
                                 select t).First();
            db.ticket.Remove(delete_ticket);
            db.places.Remove(delete_pl);
            db.SaveChanges();
        }
        public bool CheckPlace(int match_num, int num_sec, int num_row, int num_pl)
        {
            bool flag=false;
            var query = (from p in db.places
                         select p).ToList();
            if (match_num==0)
            {
                var query2 = (from m in db.match
                              where m.date_match > DateTime.Now
                              orderby m.date_match
                              select m.match_id).ToList();
                match_num = query2[0];
            }
            foreach (places p in query)
            {
                if ((num_sec ==p.sector) && (num_row == p.row) && (num_pl == p.num_place) && (match_num == p.match_id)) flag = true;
            }
            return flag;
        }
        public int AbonementCount()
        {
            var query = (from m in db.match
                          where m.date_match > DateTime.Now
                          orderby m.date_match
                          select m.match_id).ToList();
            int match_num = query[0];
            return (from p in db.places
                          where (p.match_id == match_num) && (p.season_ticket == true)
                          select p).Count();
        }
        public int TicketCount()
        {
            return (from t in db.ticket select t).Count();
        }
        public int TicketCount(DateTime date1,DateTime date2)
        {
            return (from t in db.ticket
                    join p in db.places on t.place_id equals p.place_id
                    join m in db.match on p.match_id equals m.match_id
                    where (m.date_match >= date1) && (m.date_match <= date2)
                    select t).Count();
        }
    }
}
    

            
