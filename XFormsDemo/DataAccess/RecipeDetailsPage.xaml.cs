using System;
using System.Collections.Generic;

using Xamarin.Forms;
using XFormsDemo.DataAccess.Persistence;
using SQLite;
using System.Linq;
using System.Collections.ObjectModel;

namespace XFormsDemo.DataAccess
{
    public partial class RecipeDetailsPage : ContentPage
    {
		private SQLiteAsyncConnection connection;
		private ObservableCollection<Recipe> recipes;

        public RecipeDetailsPage()
        {
            InitializeComponent();         
			connection = DependencyService.Get<ISQLiteDB>().GetConnection();
        }

		protected override async void OnAppearing()
		{
			base.OnAppearing();         
			await connection.CreateTableAsync<Recipe>();
			var recipeList = await connection.Table<Recipe>().ToListAsync();
			recipes = new ObservableCollection<Recipe>(recipeList);
			recipeListView.ItemsSource = recipes;
		}

		void Handle_Add_Clicked(object sender, System.EventArgs e)
		{
			var recipe = new Recipe { Name = "Recipe" + DateTime.Now.Ticks };
			connection.InsertAsync(recipe);
			recipes.Add(recipe);
		}

		async void Handle_Update_Clicked(object sender, System.EventArgs e)
        {
			if (recipes.Count > 0)
			{
				var recipe = (recipeListView.SelectedItem as Recipe) ?? recipes.First();
				recipe.Name += " Updated";
				await connection.UpdateAsync(recipe);
				recipeListView.ItemsSource = null;
				recipeListView.ItemsSource = recipes;
			}
        }

		async void Handle_Delete_Clicked(object sender, System.EventArgs e)
        {
			if (recipes.Count > 0)
			{
				await connection.DeleteAsync(recipes.First());
				recipes.Remove(recipes.First());
			}
        }
    }
}
