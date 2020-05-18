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
        public  string CheckUser(string l, string p)
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
            if ((role == "оператор базы данных")||(role == "администратор"))
            {
                string h_m = "С возвращением, " + name + " " + patronymic + "! Удачной работы!";
                return h_m;
            }
            else return "";
        }
        public void ShowMatches(DataGridView dgv)
        {
             matches= (from m in db.match select m).ToList();
            var query = (from m in matches
                         join t in db.team on m.team_id equals t.team_id
                         orderby m.match_id
                         select new { m.match_id, t.name,m.type,m.date_match }).ToList();
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
                         select new { t.team_id, t.name, t.city}).ToList();
            dgv.DataSource = query;
            dgv.ReadOnly = true;
            dgv.Columns[0].HeaderText = "Код команды";
            dgv.Columns[1].HeaderText = "Название команды";
            dgv.Columns[2].HeaderText = "Город";
        }
        public void AddTeam(string new_name,string new_city)
        {
            int number_team = db.team.Max(n => n.team_id) + 1;
            team new_team = new team { team_id = number_team, name=new_name, city = new_city};
            db.team.Add(new_team);
            db.SaveChanges();
            teams = db.team.OrderBy(o => o.team_id).ToList();
        }
        public List<string> List_team()
        {
            var query = (from g in db.team orderby g.team_id
                         select g.name).ToList();
            return query;
        }
        public void AddMatch(int t, string new_type,DateTime new_date)
        {
            int number_match;
            if (db.match.Count()==0) number_match=1;
            else number_match = db.match.Max(n => n.match_id) + 1;
            match new_match = new match { match_id = number_match, team_id=t,type = new_type, date_match = new_date};
            db.match.Add(new_match);
            db.SaveChanges();
            matches = db.match.OrderBy(o => o.match_id).ToList();
        }
        public string edit_n = "";
        public string edit_c = "";
        public static team item;
        public void ChooseTeam(DataGridView dgv)
        {
            if (dgv.SelectedCells.Count == 1)
            {
                List<team> query = (from t in db.team select t).ToList();
                item = query.First(w => w.team_id.ToString() == dgv.SelectedCells[0].OwningRow.Cells[0].Value.ToString());
            }
            edit_n = item.name;
            edit_c = item.city;
        }
        public void EditTeam(string t1,string t2)
        {
            var result =db.team.SingleOrDefault(w => w.team_id == item.team_id);
            result.name = t1;
            result.city = t2;
            db.SaveChanges();
            teams = db.team.OrderBy(o => o.team_id).ToList();
        }
        public string SoonMatches(int i)
        {
            var query = (from m in db.match
                         join t in db.team on m.team_id equals t.team_id
                         where m.date_match>DateTime.Now
                         orderby m.date_match
                         select new { m.type,m.date_match,t.name,t.city}).ToList();
            int max = query.Count();
            if (i >=max) return "Матч недоступен";
            else
            {
                return query[i].type + " " + query[i].date_match.ToLongDateString()+" "+ query[i].date_match.ToShortTimeString()+ " Рубин (Казань) - " + query[i].name + " (" + query[i].city + ")";
            }
        }
        public int id_match;
        public void Kod_matcha(int i)
        {
            var query = (from m in db.match
                         join t in db.team on m.team_id equals t.team_id
                         where m.date_match > DateTime.Now
                         orderby m.date_match
                         select m.match_id).ToList();
            id_match = query[i];
        }
        public float cost = 0;
        public string BuyTicket(int num_sec,int num_row,int num_pl,string type_tick,bool abon,int emp_code)
        {
            if ((num_sec < 6) || (num_sec > 31)) cost += 150;
            if (((num_sec > 5)&&(num_sec < 15))||((num_sec>22)&&(num_sec<32))) cost += 50;
            if ((num_sec >14) && (num_sec < 23)) cost += 100;
            if (num_row == 3) cost += 50;
            if (num_row == 6) cost += 1500;
            if (abon == true) cost = 10000;
            int number_pl;
            if (db.places.Count() == 0) number_pl = 1;
            else number_pl = db.places.Max(n => n.place_id) + 1;
            places new_pl = new places { place_id=number_pl,match_id=id_match,sector=num_sec,row=num_row,num_place=num_pl,type=type_tick,season_ticket=abon,price=cost };
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
            if (abon == false)
            {
                return "Вы приобрели билет на матч. С вас " + cost + " рублей. Оплатите в кассе";
            }
            else return "Вы приобрели абонемент на сезон. С вас " + cost + " рублей. Оплатите в кассе";
        }
        public bool CheckPlace(int match_num, int num_sec, int num_row, int num_pl)
        {
            bool flag=false;
            var query = (from p in db.places
                         select p).ToList();
            foreach (places p in query)
            {
                if ((num_sec ==p.sector) && (num_row == p.row) && (num_pl == p.num_place) && (match_num == p.match_id)) flag = true;
            }
            foreach (places p in query)
            {
                if ((num_sec == p.sector) && (num_row == p.row) && (num_pl == p.num_place) && (match_num == 1)&&(p.season_ticket==true)) flag = true;
            }
            return flag;
        }
    }
}
    

            
