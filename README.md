# How-to-load-images-from-internet-in-.NET-MAUI-Rotator
This document explains how to add images from internet in .NET MAUI Rotator. We can achieve it by following the below steps,

**Step 1:** Initialize the Rotator control in xaml page with all required assemblies.

**XAML:**
```
<syncfusion:SfRotator x:Name="rotator"/>
```
**Step 2:** Create the Model class with the properties need to be assigned.

**C#:**
**Model**
```
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
```
**Step 3:** Create the ViewModel class and add image collection of URL that needs to be bound with the data source.

**C#**
**ViewModel**
```
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
```
**Step 4:** Initialize the Rotator control in XAML page in which the ViewModel class set to BindingContext.
```
<syncfusion:SfRotator 
                x:Name="rotator"  
                ItemsSource="{Binding ImageCollection}">

        <syncfusion:SfRotator.ItemTemplate>
            <DataTemplate>
                <Image Source="{Binding Image}"/>
            </DataTemplate>
        </syncfusion:SfRotator.ItemTemplate>
    </syncfusion:SfRotator>
```
