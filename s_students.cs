//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ControlWork
{
    using System;
    using System.Collections.Generic;
    
    public partial class s_students
    {
        public int id { get; set; }
        public string surname { get; set; }
        public string name { get; set; }
        public string middlename { get; set; }
        public Nullable<int> id_group { get; set; }
    
        public virtual s_in_group s_in_group { get; set; }
    }
}