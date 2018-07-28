﻿using System.Configuration;
using MaterialDesignThemes.Wpf;
using System;

namespace ReindexAutomation.Client.Domain
{
    public class MainWindowViewModel
    {
        public MainWindowViewModel(ISnackbarMessageQueue snackbarMessageQueue)
        {
            if (snackbarMessageQueue == null) throw new ArgumentNullException(nameof(snackbarMessageQueue));

            Sections = new[]
            {
                new Section("Home", new Home(),
                    new[]
                    {
                        new DocumentationLink(DocumentationLinkType.Wiki,
                            $"{ConfigurationManager.AppSettings["GitHub"]}/wiki", "WIKI"),
                        DocumentationLink.DemoPageLink<Home>()
                    }
                ),
                new Section("SolrCloud Managment", new ZookeeperManagment{DataContext = new ZookeeperManagmentViewModel(snackbarMessageQueue)},
                    new[]
                    {
                        new DocumentationLink(DocumentationLinkType.Wiki,
                            $"{ConfigurationManager.AppSettings["GitHub"]}/wiki", "WIKI"),
                        DocumentationLink.DemoPageLink<Home>()
                    }
                ),
                new Section("Zookeper Managment", new ZookeeperManagment{DataContext = new ZookeeperManagmentViewModel(snackbarMessageQueue)},
                    new[]
                    {
                        new DocumentationLink(DocumentationLinkType.Wiki,
                            $"{ConfigurationManager.AppSettings["GitHub"]}/wiki", "WIKI"),
                        DocumentationLink.DemoPageLink<Home>()
                    }
                )
            };
        }

        public Section[] Sections { get; }
    }
}