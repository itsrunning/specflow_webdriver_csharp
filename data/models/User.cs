namespace SpecFlowSample.data.models
{
    class User
    {
        public string Name { get; set; }

        public User(string name)
        {
            Name = name;
        }

        public static void DeleteAll()
        {
            Db.Run(string.Format("delete from users"));                     
        }

        public void Create()
        {
            Db.Run(string.Format("insert into users (name) values ('{0}')", Name));            
        }
    }
}
