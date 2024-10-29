using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace OurHeroApiWithCodeFirstApproach.Model
{
    public class OurHero
    {
        [Table("tblOurHeros")]
        public class OurHeros
        {
            [Key]
            public int? Id { get; set; }

            //[Key]
            [Required]
            public string FirstName { get; set; }
            [Required]
            public string LastName { get; set; }

            public bool isActive { get; set; }


        }
    }
}
