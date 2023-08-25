//using AutoMapper;
//using HotellistingAPI.Data;
//using HotellistingAPI.Models;
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Identity;
//using Microsoft.AspNetCore.Mvc;

//namespace HotellistingAPI.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class AccountController : ControllerBase
//    {
//        private readonly UserManager<ApiUser> _userManager;
//        private readonly SignInManager<ApiUser> _signInManager;
//        private readonly ILogger<AccountController> _logger;
//        private readonly IMapper _mapper;

//        public AccountController(UserManager<ApiUser> userManager,
//            SignInManager<ApiUser> signInManager,
//            ILogger<AccountController> logger, 
//            IMapper mapper)
//        {
//            _userManager = userManager;
//            _signInManager = signInManager;
//            _logger = logger;
//            _mapper = mapper;
//        }
    
//        [HttpPost]
//        public async Task<IActionResult> Register([FromBody] UserDTO userDTO)
//        {
//            _logger.LogInformation($"Registration Attempt for {userDTO.Email}");
//            if (!ModelState.IsValid)
//            {
//                return BadRequest(ModelState);
//            }
//            try
//            {
//                var user = _mapper.Map<ApiUser>(userDTO);
//                var result = await _userManager.CreateAsync(user);

//                if (!result.Succeeded)
//                {
//                    return BadRequest("$User Registration Attempt Failed");
//                }

//            }
//            catch(Exception ex)
//            {
//                _logger.LogError(ex, $"Something Went Wrong in the {nameof(Register)}");
//                return Problem($"Something Went Wrong in the {nameof(Register)}", statusCode: 500);
//            }
//        }

//        [HttpPost]
//        public async Task<IActionResult> Login([FromBody] LoginUserDTO userDTO)
//        {
//            _logger.LogInformation($"Login Attempt for {userDTO.Email}");
//            if (!ModelState.IsValid)
//            {
//                return BadRequest(ModelState);
//            }
//            try
//            {
//                var user = _mapper.Map<ApiUser>(userDTO);
//                var result = await _userManager.CreateAsync(user);

//                if (!result.Succeeded)
//                {
//                    return BadRequest("$User Login Attempt Failed");
//                }

//            }
//            catch (Exception ex)
//            {
//                _logger.LogError(ex, $"Something Went Wrong in the {nameof(Register)}");
//                return Problem($"Something Went Wrong in the {nameof(Register)}", statusCode: 500);
//            }
//        }
//    }
//}
