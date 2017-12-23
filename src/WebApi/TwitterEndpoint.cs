namespace src.Webapi
{
    using src.Webapi.TwitterControllers;

    public class TwitterEndpoint 
    {
        public TweetsController Tweets { get; set; }

        public StatusController Statuses { get; set; } 

        public AccountController Account { get; set; }

        public ApplicationController Application { get; set; }

        public BlocksController Blocks { get; set; }

        public CollectionsController Collections { get; set; }

        public DirectMessagesController DirectMessages { get; set; }  

        public FavoritesController Favorites { get; set; }

        private FollowersController followers;

        public FriendsController Friends { get; set; }  

        public FriendshipsController Friendships { get; set; }

        public GeoController Geo { get; set; }

        public HelpController Help { get; set; }

        public ListsController Lists { get; set; }

        public MediaController Media { get; set; }

        public MutesController Mutes { get; set; }     

        public TrendsController Trends { get; set; } 
    
        public UsersController Users { get; set; } 
    }
}