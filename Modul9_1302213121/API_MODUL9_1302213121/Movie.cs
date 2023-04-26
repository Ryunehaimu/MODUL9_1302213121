namespace API_MODUL9_1302213121
{
    public class Movie
    {
        public String title { get;set;}
        public String Director { get;set;}
        public String[] Stars { get;set;}
        public String Description { get;set;}
        public Movie() {}
        public Movie(String title, String Director, String[] Stars, String Description) { 
            this.title = title; this.Director = Director;this.Stars = Stars;this.Description = Description;
        }
    }
}