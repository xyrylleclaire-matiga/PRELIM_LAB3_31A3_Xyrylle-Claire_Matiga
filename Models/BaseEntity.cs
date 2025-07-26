namespace PRELIM_LAB3_31A3_Xyrylle_Claire_Matiga.Models
{
    public class BaseEntity
    {
       public string FirstName { get; set; }
       public string LastName { get; set; }
       public string MiddleName { get; set; }
       public DateTime bday { get; set; }

        public string GetFullName(){
            return $"{FirstName} {MiddleName[0]}. {LastName}";}

        public int GetAge(){
            return DateTime.Now.Year - bday.Year;}

        public virtual string GetDescription(){
            return $"{GetFullName()} - {GetAge()} years old";}

    }
}
