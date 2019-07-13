﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TipManager.Model;
using TipManager.Services;
using TipManager.View;

namespace TipManager.Presenter
{
    class HomePresenter
    {
        // Private or nah
        private TipManagerModel tipManager;
        
        // Private or nah
        private TipManagerServices services;

        private IHome homeView;

        public HomePresenter(IHome homeView, TipManagerModel tipManager, TipManagerServices services)
        {
            this.homeView = homeView;
            this.tipManager = tipManager;
            this.services = services;
            homeView.homeLoaded += new EventHandler(OnHomeLoaded);
        }

        public void OnHomeLoaded(object sender, EventArgs e)
        {
            DisplayAll();
        }

        public void DisplayTotal()
        {
            services.passTotalToModel();
            homeView.TxtTotal = "$" + tipManager.Total.ToString();

        }

        public void DisplayTotalMade()
        {
            services.passTotalMadeToModel();
            homeView.TxtTotalMade = "$" + tipManager.TotalMade.ToString();
        }

        public void DisplayTotalSpent()
        {
            services.passTotalSpentToModel();
            homeView.TxtTotalSpent = "$" + tipManager.TotalSpent.ToString();
        }

        public void DisplayTotalHoursWorked()
        {
            services.passTotalHoursWorkedToModel();
            homeView.TxtTotalHours = tipManager.TotalHours.ToString();
        }

        public void DisplayAll()
        {
            DisplayTotal();
            DisplayTotalMade();
            DisplayTotalSpent();
            DisplayTotalHoursWorked();
        }

    }
}
