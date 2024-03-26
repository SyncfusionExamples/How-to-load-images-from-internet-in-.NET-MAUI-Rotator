namespace RotatorSample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
    }

    public class RotatorModel
    {
        public RotatorModel(string image)
        {
            Image = image;
        }
        private string _image;
        public string Image
        {
            get { return _image; }
            set { _image = value; }
        }
    }

    public class RotatorViewModel
    {
        public RotatorViewModel()
        {
            ImageCollection.Add(new RotatorModel("https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQe0ub78kIqvmA13W9Sr6VdDcu0ciXwScvgKgDKQuitqLAQoUxJng"));
            ImageCollection.Add(new RotatorModel("https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQ-6rRDNIfS0JE47sDceHbY4FkY15Hl88OOzC_BFIRWcawLlIsk"));
            ImageCollection.Add(new RotatorModel("https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRSgxX4vNJToErxuEprfne9xvIOkLO262VfYNcDm5iCGnagzJDs"));
            ImageCollection.Add(new RotatorModel("https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSsIYs-RihLWXHvr6tqkOVxaRvjBqIUZpqH6_gJD0spZbB46rSRfQ"));
            ImageCollection.Add(new RotatorModel("https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRTCkvGBaNwtSdkefoj_2QLYK4KRwHNH6hgaPIwXf2cqd1AN_CG"));
        }
        private List<RotatorModel> imageCollection = new List<RotatorModel>();
        public List<RotatorModel> ImageCollection
        {
            get { return imageCollection; }
            set { imageCollection = value; }
        }
    }

}
