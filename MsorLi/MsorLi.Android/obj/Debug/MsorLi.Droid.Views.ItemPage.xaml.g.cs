//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MsorLi.Views {
    
    
<<<<<<< Updated upstream
    [global::Xamarin.Forms.Xaml.XamlFilePathAttribute("C:\\Users\\sagee\\Source\\Repos\\FinalProject\\MsorLi\\MsorLi\\Views\\ItemPage.xaml")]
=======
    [global::Xamarin.Forms.Xaml.XamlFilePathAttribute("/Users/Idan Marciano/Projects/SaConway/FinalProject2.git/MsorLi/MsorLi/Views/Item" +
        "Page.xaml")]
>>>>>>> Stashed changes
    public partial class ItemPage : global::Xamarin.Forms.ContentPage {
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "0.0.0.0")]
        private global::Xamarin.Forms.ScrollView MyScrollView;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "0.0.0.0")]
        private global::Xamarin.Forms.CarouselView imagesView;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "0.0.0.0")]
        private global::Xamarin.Forms.StackLayout SaveStack;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "0.0.0.0")]
        private global::Xamarin.Forms.StackLayout UnSaveStack;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "0.0.0.0")]
        private global::Xamarin.Forms.Label title;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "0.0.0.0")]
        private global::Xamarin.Forms.Label subCategory;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "0.0.0.0")]
        private global::Xamarin.Forms.Label condition;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "0.0.0.0")]
        private global::Xamarin.Forms.Label location;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "0.0.0.0")]
        private global::Xamarin.Forms.Label date;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "0.0.0.0")]
        private global::Xamarin.Forms.Label description;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "0.0.0.0")]
        private global::Xamarin.Forms.Label contact_name;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "0.0.0.0")]
        private global::Xamarin.Forms.Label contact_number;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "0.0.0.0")]
        private global::Xamarin.Forms.Label email;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "0.0.0.0")]
        private global::Xamarin.Forms.Label UserLabel;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "0.0.0.0")]
        private global::Xamarin.Forms.ScrollView ItemList;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "0.0.0.0")]
        private global::Xamarin.Forms.StackLayout StackUserItems;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "0.0.0.0")]
        private global::Xamarin.Forms.ActivityIndicator MyActivityIndicator;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "0.0.0.0")]
        private void InitializeComponent() {
            global::Xamarin.Forms.Xaml.Extensions.LoadFromXaml(this, typeof(ItemPage));
            MyScrollView = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Xamarin.Forms.ScrollView>(this, "MyScrollView");
            imagesView = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Xamarin.Forms.CarouselView>(this, "imagesView");
            SaveStack = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Xamarin.Forms.StackLayout>(this, "SaveStack");
            UnSaveStack = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Xamarin.Forms.StackLayout>(this, "UnSaveStack");
            title = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Xamarin.Forms.Label>(this, "title");
            subCategory = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Xamarin.Forms.Label>(this, "subCategory");
            condition = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Xamarin.Forms.Label>(this, "condition");
            location = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Xamarin.Forms.Label>(this, "location");
            date = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Xamarin.Forms.Label>(this, "date");
            description = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Xamarin.Forms.Label>(this, "description");
            contact_name = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Xamarin.Forms.Label>(this, "contact_name");
            contact_number = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Xamarin.Forms.Label>(this, "contact_number");
            email = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Xamarin.Forms.Label>(this, "email");
            UserLabel = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Xamarin.Forms.Label>(this, "UserLabel");
            ItemList = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Xamarin.Forms.ScrollView>(this, "ItemList");
            StackUserItems = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Xamarin.Forms.StackLayout>(this, "StackUserItems");
            MyActivityIndicator = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Xamarin.Forms.ActivityIndicator>(this, "MyActivityIndicator");
        }
    }
}
