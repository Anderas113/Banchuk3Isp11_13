//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Banchuk3Isp11_13.EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class Schedule
    {
        public int IdCabinet { get; set; }
        public int IdDoctor { get; set; }
        public string NumberOfWeek { get; set; }
        public System.TimeSpan TimeScheduleBegin { get; set; }
        public System.TimeSpan TimeScheduleEnd__TimeScheduleEnd__TimeScheduleEnd { get; set; }
    
        public virtual Cabinet Cabinet { get; set; }
        public virtual Doctor Doctor { get; set; }
    }
}
