//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TelecomNevaSvyazTest.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Abonents
    {
        public string NumberAbonent { get; set; }
        public string FIO { get; set; }
        public int IDGender { get; set; }
        public System.DateTime DateOfBirth { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string AdressPropiski { get; set; }
        public string Adress { get; set; }
        public string SerialAndNumber { get; set; }
        public string Code { get; set; }
        public string Issue { get; set; }
        public System.DateTime DateOfIssue { get; set; }
        public string NumberOfDogovor { get; set; }
        public System.DateTime DateOfStart { get; set; }
        public int IDTypeOfDogovor { get; set; }
        public string Reason { get; set; }
        public int PersonalAccount { get; set; }
        public string Services { get; set; }
        public Nullable<System.DateTime> DateOfEnd { get; set; }
        public string IDAbonentEqupment { get; set; }
    
        public virtual AbonentEqupment AbonentEqupment { get; set; }
        public virtual Gender Gender { get; set; }
        public virtual TypeOfDogovor TypeOfDogovor { get; set; }
    }
}
