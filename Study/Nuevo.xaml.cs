﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
namespace App11
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Nuevo : ContentPage
	{
		public Nuevo()
		{
			InitializeComponent();
		}

		public void MovePage(object obj, EventArgs args)
		{
			Navigation.PushAsync(new AgregarCurso());
		}
	}
}