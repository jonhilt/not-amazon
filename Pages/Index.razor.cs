using System.Collections.Generic;
using Microsoft.AspNetCore.Components;
using NotAmazon.Models;

namespace NotAmazon.Pages
{
    public class Index_razor : ComponentBase
    {
        [Parameter]
        public IEnumerable<CollectionModel> Collections { get; set; } = new List<CollectionModel>
        {
            new CollectionModel
            {
                Title = "Featured Albums",
                SeeMoreLink = "/see-more",
                Items = new List<CollectionModel.CollectionItem>
                {
                    new CollectionModel.CollectionItem
                    {
                        Description = "Amazing",
                        Title = "Amazing Album Number 1",
                        ImageUrl = "https://via.placeholder.com/250"
                    },
                    new CollectionModel.CollectionItem
                    {
                        Description = "Another great album",
                        Title = "Amazing Album Number 2",
                        ImageUrl = "https://via.placeholder.com/250"
                    },
                    new CollectionModel.CollectionItem
                    {
                        Description = "Even more incredible",
                        Title = "Amazing Album Number 3",
                        ImageUrl = "https://via.placeholder.com/250"
                    },
                    new CollectionModel.CollectionItem
                    {
                        Description = "How do they keep doing it?!",
                        Title = "Amazing Album Number 4",
                        ImageUrl = "https://via.placeholder.com/250"
                    }
                }
            },
            new CollectionModel
            {
                Title = "Hot Right Now",
                SeeMoreLink = "/hot-now",
                Items = new List<CollectionModel.CollectionItem>
                {
                    new CollectionModel.CollectionItem
                    {
                        Title = "Cheesy Pop",
                        Description = "Amazing Pop Classics",
                        ImageUrl = "https://via.placeholder.com/250"
                    },
                    new CollectionModel.CollectionItem
                    {
                        Title = "Best of Indie",
                        Description = "Relive the nineties",
                        ImageUrl = "https://via.placeholder.com/250"
                    },
                    new CollectionModel.CollectionItem
                    {
                        Title = "Life me up karaoke",
                        Description = "Beat the lockdown blues with some terrible singing",
                        ImageUrl = "https://via.placeholder.com/250"
                    },
                    new CollectionModel.CollectionItem
                    {
                        Title = "Timeless classics",
                        Description = "Classic, timeless, endless",
                        ImageUrl = "https://via.placeholder.com/250"
                    }
                }
            }
        };
    }
}