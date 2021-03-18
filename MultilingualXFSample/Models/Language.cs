
namespace MultilingualXFSample.Models
{
    public class Language
    {
        public Language(string name, string ci)
        {
            Name = name;            //np. English
            CI = ci;                //CodeIgniter  //np. en
        }
        public string Name { get; set; }

        //  private string _name;
        //  public string Name
        //  {
        //      get { return _name; }
        //      set { _name = value; }
        //  }

        public string CI { get; set; }

    }
}
