//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Football_Ticket
{
    using System;
    using System.Collections.Generic;
    
    public partial class ticket
    {
        public int ticket_id { get; set; }
        public Nullable<int> place_id { get; set; }
        public Nullable<int> emp_id { get; set; }
    
        public virtual employer employer { get; set; }
        public virtual places places { get; set; }
    }
}
