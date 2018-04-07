using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FriendsApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace FriendsApp.Controllers
{
    public class FriendController : Controller
    {
        private static List<FriendModel> Friends = new List<FriendModel>()
        {
            new FriendModel(){Id = 1, Ime = "Marko", MestoZiveenje = "Skopje"},
            new FriendModel(){Id = 2, Ime = "Darko", MestoZiveenje = "Berovo"},
            new FriendModel(){Id = 3, Ime = "Zarko", MestoZiveenje = "Bitola"}
        };

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ShowFriends()
        {
            return View(Friends);
        }

        public ActionResult DeleteFriend(int id)
        {
            Friends.RemoveAt(id);
            return View("ShowFriends", Friends);
        }

        public ActionResult UpdateFriend(int id)
        {
            FriendModel model = Friends.ElementAt(id);
            model.change = id;
            return View(model);
        }

        [HttpPost]
        public ActionResult UpdateFriend(FriendModel model)
        {
            if (!ModelState.IsValid)
            {
                return View("UpdateFriend", model);
            }
            FriendModel updateModel = Friends.ElementAt(model.change);
            updateModel.Id = model.Id;
            updateModel.Ime = model.Ime;
            updateModel.MestoZiveenje = model.MestoZiveenje;
            return View("ShowFriends", Friends);
        }
    }
}