namespace DBEngine.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Test")]
    public partial class Test
    {
        public int id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [StringLength(50)]
        public string Adress { get; set; }

        [Required]
        [StringLength(50)]
        public string CounterType { get; set; }

        [Required]
        [StringLength(50)]
        public string CounterNum { get; set; }

        public int? PastVal { get; set; }

        public int? CurrentVal { get; set; }

        public int? Difference { get; set; }

        public int TransformCoef { get; set; }

        public int? Consumed { get; set; }
    }
}
