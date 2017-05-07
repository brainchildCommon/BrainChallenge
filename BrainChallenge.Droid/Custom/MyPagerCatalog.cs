namespace BrainChallenge.Droid
{
    // TreePage: contains image resource ID and caption for a tree:
    public class MyPagerPage
    {
        // Image ID for this tree image:
        public int imageId;

        // Caption text for this image:
        public string caption;

        // Returns the ID of the image:
        public int ImageID { get { return imageId; } }

        // Returns the caption text for the image:
        public string Caption { get { return caption; } }
    }

    // Tree catalog: holds image resource IDs and caption text:
    public class MyPagerCatalog
    {
        // Built-in tree catalog (could be replaced with a database)
		static MyPagerPage[] myPagerBuiltInCatalog = {
			new MyPagerPage { imageId = Resource.Drawable.detective_game_title,
                           caption = "No.1" },
			new MyPagerPage { imageId = Resource.Drawable.detective_game_title,
                           caption = "No.2" },
			new MyPagerPage { imageId = Resource.Drawable.detective_game_title,
                           caption = "No.3" },
			new MyPagerPage { imageId = Resource.Drawable.detective_game_title,
                           caption = "No.4" },
			new MyPagerPage { imageId = Resource.Drawable.detective_game_title,
                           caption = "No.5" }
        };

        // Array of tree pages that make up the catalog:
		private MyPagerPage[] myPagerPages;

        // Create an instance copy of the built-in tree catalog:
        public MyPagerCatalog () { myPagerPages = myPagerBuiltInCatalog; }

        // Indexer (read only) for accessing a tree page:
        public MyPagerPage this[int i] { get { return myPagerPages[i];  } }

        // Returns the number of tree pages in the catalog:
        public int NumTrees {  get { return myPagerPages.Length; } }
    }
}