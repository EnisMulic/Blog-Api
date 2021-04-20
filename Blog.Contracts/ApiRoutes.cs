namespace Blog.Contracts
{
    public static class ApiRoutes
    {
        public const string Root = "api";
        
        public static class Posts
        {
            public const string Base = Root + "/posts";
            public const string Get = Base;
            public const string GetBySlug = Base + "/{slug}";
            public const string Create = Base;
            public const string Update = Base + "/{slug}";
            public const string Delete = Base + "/{slug}";
        }

        public static class Tags
        {
            public const string Base = Root + "/tags";
            public const string Get = Base;
        }
    }
}
