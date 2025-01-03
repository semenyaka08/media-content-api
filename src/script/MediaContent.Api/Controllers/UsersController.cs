using MediaContent.Api.DTOs;
using MediaContent.Api.Exceptions;
using MediaContent.Api.Mappers;
using MediaContent.Api.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace MediaContent.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UsersController(IUsersRepository usersRepository, ILogger<UsersController> logger) : ControllerBase
{
    [HttpGet("{id:int}")]
    public async Task<IActionResult> GetUserById([FromRoute] int id)
    {
        logger.LogInformation("Getting user with id {id}", id);

        var user = await usersRepository.GetUserByIdAsync(id);

        if (user == null)
            throw new NotFoundException(nameof(User), id.ToString());

        var mappedUser = user.ToDto();

        return Ok(mappedUser);
    }

    [HttpGet]
    public async Task<IActionResult> GetUsers()
    {
        logger.LogInformation("Getting all users from database");

        var users = await usersRepository.GetAllUsersAsync();

        var mappedUsers = users.Select(z => z.ToDto());

        return Ok(mappedUsers);
    }

    [HttpPost]
    public async Task<IActionResult> CreateUser([FromBody] UserAddRequest userAddRequest)
    {
        logger.LogInformation("Adding user {@product}", userAddRequest);
        
        var mappedUser = userAddRequest.ToUser();

        var id = await usersRepository.AddUserAsync(mappedUser);

        return CreatedAtAction(nameof(GetUserById), new { id }, new { id });
    }

    [HttpDelete("{id:int}")]
    public async Task<IActionResult> RemoveUser([FromRoute] int id)
    {
        logger.LogInformation("Deleting user with id: {userId}", id);

        var user = await usersRepository.GetUserByIdAsync(id);
        
        if(user == null)
            throw new NotFoundException(nameof(User), id.ToString());

        await usersRepository.DeleteUserAsync(user);

        return NoContent();
    }

    [HttpPut("{id:int}")]
    public async Task<IActionResult> UpdateUser([FromBody] UserAddRequest updateRequest, [FromRoute] int id)
    {
        var user = await usersRepository.GetUserByIdAsync(id);
        
        if(user == null)
            throw new NotFoundException(nameof(User), id.ToString());

        var mappedUserRequest = updateRequest.ToUser();

        user.FirstName = mappedUserRequest.FirstName;
        user.LastName = mappedUserRequest.LastName;
        user.Email = mappedUserRequest.Email;
        user.HashedPassword = mappedUserRequest.HashedPassword;

        await usersRepository.SaveChangesAsync();

        return NoContent();
    }
}