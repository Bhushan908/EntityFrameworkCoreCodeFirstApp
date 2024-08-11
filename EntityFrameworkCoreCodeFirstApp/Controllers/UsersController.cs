using EntityFrameworkCoreCodeFirstApp.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EntityFrameworkCoreCodeFirstApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly UserContext _userContext;
        public UsersController(UserContext userContext)
        {
            this._userContext = userContext;
        }

        [HttpGet]
        [Route("GetUsers")]
        public List<Users> GetUsers()
        {
            return _userContext.Users.ToList();
        }

        [HttpPost]
        [Route("AddUser")]
        public string AddUser(Users users)
        {
            _userContext.Users.Add(users);
            _userContext.SaveChanges();
            return $"User {users.Name} added successfully";
        }

        [HttpGet]
        [Route("GetUser")]
        public Users GetUsers(int id)
        {
            return _userContext.Users.Find(id);
        }

        [HttpPost]
        [Route("UpdateUser")]
        public string UpdateUser(Users users)
        {
            _userContext.Users.Update(users);
            _userContext.SaveChanges ();
            return $"User {users.Name} updated successfully";
        }

        [HttpPost]
        [Route("DeleteUser")]
        public string DeleteUser(int id)
        {
            _userContext.Users.Remove(GetUsers(id));
            _userContext.SaveChanges () ;
            return $"User {id} successfully deleted";
        }
    }
}
