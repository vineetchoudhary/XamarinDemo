using System;
using System.Collections.Generic;

using Xamarin.Forms;
using XFormsDemo.DataAccess.Netflix;
using XFormsDemo.DataAccess.Rest;
using XFormsDemo.DataAccess;
using XFormsDemo.AlertActionSheet;
using XFormsDemo.Carousel;
using XFormsDemo.MasterDetails;
using XFormsDemo.Navigations;
using XFormsDemo.TabBarView;
using XFormsDemo.Forms;

namespace XFormsDemo
{
    public partial class SuperMainPage : ContentPage
    {
        public SuperMainPage()
        {
            InitializeComponent();
        }


        //Data Access
        void Handle_Netflix_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new MovieListPage());
        }

        void Handle_APIs_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new RestPostPage());
        }

        void Handle_Recipe_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new RecipeDetailsPage());
        }

        void Handle_AppSetting_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new ApplicationPropertiesPage());
        }


        //Layout
        //Absolute Layout
        void Handle_Absolute_Layout_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new AbsoluteLayoutPage());
        }

        void Handle_Absolute_Layout_Image_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new AbsoluteLayoutImagePage());
        }

        void Handle_Absolute_Layout_Payment_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new AbsoluteLayoutPayPage());
        }

        //Relative Layout
        void Handle_Relative_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new RelativeLayoutPage());
        }

        void Handle_Relative_Cart_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new RelativeLayoutCartPage());
        }

        void Handle_Relative_Image_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new ImageListPage());
        }

        void Handle_Relative_Complex_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new RelativeLayoutComplexPage());
        }

        //Grid Layout
        void Handle_Grid_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new GridPage());
        }

        void Handle_Grid_Login_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new GridLoginPage());
        }

        void Handle_Grid_DialPad_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new DialPadPage());
        }

        //List Layout
        void Handle_List_View_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new ListPage());
        }

        //StackView Insta
        void Handle_Instagram_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new PhotoPage());
        }

        void Handle_Quotes_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new QuotesPage());
        }

        void Handle_Stack_Login_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new StackPage());
        }

        //Pages
        void Handle_Carousel_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new MainCarouselPage());
        }

        void Handle_MasterDetails_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new ContactPage());
        }

        void Handle_Navigation_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new IntroductionPage());
        }

        void Handle_Navigation_Problem_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new NavigationProblemPage());
        }



        //Controls
        void Handle_Alert_ActionSheet_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new AlertActionSheetPage());
        }

        void Handle_TabBar_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new TabBarPage());
        }

        void Handle_MixedControls_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new ControllsPage());
        }

        void Handle_TableView_Form_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new TableViewFormPage());
        }

        void Handle_CircleImage_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new ButtonImagePage());
        }

        //Other 
        void Handle_Safe_Area_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new InitialPage());
        }
    }
}
