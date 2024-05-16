﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
#nullable disable

using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Raktdaan.Models;

namespace Raktdaan.Areas.Identity.Pages.Account.Manage
{
    public class IndexModel : PageModel
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;

        public IndexModel(
            UserManager<IdentityUser> userManager,
            SignInManager<IdentityUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        /// <summary>
        ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
        ///     directly from your code. This API may change or be removed in future releases.
        /// </summary>
        public string Username { get; set; }

        /// <summary>
        ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
        ///     directly from your code. This API may change or be removed in future releases.
        /// </summary>
        [TempData]
        public string StatusMessage { get; set; }

        /// <summary>
        ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
        ///     directly from your code. This API may change or be removed in future releases.
        /// </summary>
        [BindProperty]
        public InputModel Input { get; set; }

        /// <summary>
        ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
        ///     directly from your code. This API may change or be removed in future releases.
        /// </summary>
        public class InputModel
        {
            /// <summary>
            ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
            ///     directly from your code. This API may change or be removed in future releases.
            /// </summary>
            [Phone]
            [Display(Name = "Phone number")]
            public string PhoneNumber { get; set; }
            [Required]
            [Display(Name = "Full Name")]
            public string Full_Name { get; set; }
            [Display(Name = "Blood Group")]
            public string? Blood_group { get; set; }
            [Display(Name = "State")]
            public string? State { get; set; }
            [Display(Name = "City")]
            public string? City { get; set; }
            [Display(Name = "Country")]
            public string? Country { get; set; }
            [Display(Name = "Phone")]
            public string? Phone { get; set; }
            [Display(Name = "Postal Code")]
            public string? PostalCode { get; set; }
            [Display(Name = "Address")]
            public string? Address { get; set; }
            [EmailAddress]
            public string Email { get; set; }
        }

        private async Task LoadAsync(IdentityUser user)
        {
            var userName = await _userManager.GetUserNameAsync(user);
            var phoneNumber = await _userManager.GetPhoneNumberAsync(user);

            var email = await _userManager.GetEmailAsync(user);

            var applicationUser = await _userManager.FindByIdAsync(user.Id) as ApplicationUser;
            if (applicationUser == null)
            {
                // Handle the case where the user is not an instance of ApplicationUser
                // For example, you could throw an exception or log an error message
                throw new Exception("User is not an instance of ApplicationUser");
            }

            Username = userName;

            Input = new InputModel
            {
                PhoneNumber = phoneNumber,
                Full_Name = applicationUser.Full_Name,
                Blood_group = applicationUser.Blood_group,
                State = applicationUser.State,
                City = applicationUser.City,
                Country = applicationUser.Country,
                Phone = applicationUser.Phone,
                PostalCode = applicationUser.PostalCode,
                Address = applicationUser.Address,
                Email = email
            };
        }

        public async Task<IActionResult> OnGetAsync()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
            }

            await LoadAsync(user);
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            var user = await _userManager.GetUserAsync(User);

            if (user == null)
            {
                return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
            }

            if (!ModelState.IsValid)
            {
                await LoadAsync(user);
                return Page();
            }
            var applicationUser = await _userManager.FindByIdAsync(user.Id) as ApplicationUser;
            if (applicationUser == null)
            {
                // Handle the case where the user is not an instance of ApplicationUser
                // For example, you could throw an exception or log an error message
                throw new Exception("User is not an instance of ApplicationUser");
            }
            var phoneNumber = await _userManager.GetPhoneNumberAsync(user);
            if (Input.PhoneNumber != phoneNumber)
            {
                var setPhoneResult = await _userManager.SetPhoneNumberAsync(user, Input.PhoneNumber);
                if (!setPhoneResult.Succeeded)
                {
                    StatusMessage = "Unexpected error when trying to set phone number.";
                    return RedirectToPage();
                }
            }
            applicationUser.Full_Name = Input.Full_Name;
            applicationUser.Blood_group = Input.Blood_group;
            applicationUser.State = Input.State;
            applicationUser.City = Input.City;
            applicationUser.Country = Input.Country;
            applicationUser.Phone = Input.Phone;
            applicationUser.PostalCode = Input.PostalCode;
            applicationUser.Address = Input.Address;

            var updateResult = await _userManager.UpdateAsync(applicationUser);
            if (!updateResult.Succeeded)
            {
                StatusMessage = "Unexpected error when trying to update user details.";
                return RedirectToPage();
            }
            await _signInManager.RefreshSignInAsync(user);
            StatusMessage = "Your profile has been updated";
            return RedirectToPage();
        }
    }
}
