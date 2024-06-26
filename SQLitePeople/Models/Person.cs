using SQLite;

namespace SQLitePeople.Models
{
    [Table("people")]
    public class Person
    {
        [PrimaryKey,AutoIncrement]
        public int IdPerson  {get;set;}
        [MaxLength(250),Unique]
        public string Name { get; set; }

    }
}
