//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Domain
{
    using System;
    using System.Collections.Generic;
    
    public partial class SYS_MODULE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SYS_MODULE()
        {
            this.SYS_PERMISSION = new HashSet<SYS_PERMISSION>();
        }
    
        public int ID { get; set; }
        public string FK_BELONGSYSTEM { get; set; }
        public int PARENTID { get; set; }
        public string NAME { get; set; }
        public string ALIAS { get; set; }
        public int MODULETYPE { get; set; }
        public string ICON { get; set; }
        public string MODULEPATH { get; set; }
        public bool ISSHOW { get; set; }
        public int SHOWORDER { get; set; }
        public int LEVELS { get; set; }
        public bool IsVillage { get; set; }
        public string CREATEUSER { get; set; }
        public Nullable<System.DateTime> CREATEDATE { get; set; }
        public string UPDATEUSER { get; set; }
        public Nullable<System.DateTime> UPDATEDATE { get; set; }
    
        public virtual SYS_SYSTEM SYS_SYSTEM { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SYS_PERMISSION> SYS_PERMISSION { get; set; }
    }
}
