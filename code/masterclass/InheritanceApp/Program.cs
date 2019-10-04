using System;

namespace InheritanceApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Post post1 = new Post("thanks for the birthday wishes", true, "Mit");
            Console.WriteLine(post1.ToString());

            ImagePost imagePost1 = new ImagePost("check out my new shoes", "mit", "image.png", true);
            Console.WriteLine(imagePost1.ToString());

            Console.ReadLine();
        }
    }

    class Post
    {
        private static int currentPostId;


        // properties

        protected int ID { get; set; }
        protected string Title { get; set; }
        protected bool IsPublic { get; set; }
        protected string SendByUsername {get;set;}

        public Post()
        {
            ID = 0;
            Title = "My First Post";
            IsPublic = true;
            SendByUsername = "mit";
        }

        public Post(string title, bool isPublic, string userName)
        {
            this.ID = GetNextIId();
            this.Title = title;
            this.IsPublic = isPublic;
            this.SendByUsername = userName;
        }

        protected int GetNextIId()
        {
            return ++currentPostId;
        }
        public void Update(string title, bool isPublic)
        {
            this.Title = title;
            this.IsPublic = isPublic;
        }

        public override string ToString()
        {
            return String.Format("{0} - {1} - by {2}", this.ID, this.Title, this.SendByUsername);
        }
    }

    class ImagePost : Post
    {
        public string ImageUrl { get; set; }
        
        public ImagePost() { }

        public ImagePost(string title, string byUserName, string imageUrl, bool isPublic)
        {
            // The following properties and the GetNextId are from the Post class
            this.ID = GetNextIId();
            this.Title = title;
            this.SendByUsername = byUserName;
            this.IsPublic = IsPublic;
            // Property imageUrl is a member of ImagePost, but not of Post
            this.ImageUrl = imageUrl;
        }

        public override string ToString()
        {
            return String.Format("{0} - {1} - by {2} [link to image {3}]", this.ID, this.Title, this.SendByUsername,this.ImageUrl);
        }
    }
}
