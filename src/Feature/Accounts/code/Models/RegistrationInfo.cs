﻿using Sitecore.Demo.Shared.Feature.Accounts.Attributes;
using Sitecore.Demo.Shared.Foundation.Dictionary.Repositories;
using System.ComponentModel.DataAnnotations;

namespace Sitecore.Demo.Shared.Feature.Accounts.Models
{
    public class RegistrationInfo
    {
        [Display(Name = nameof(EmailCaption), ResourceType = typeof(RegistrationInfo))]
        [Required(ErrorMessageResourceName = nameof(Required), ErrorMessageResourceType = typeof(RegistrationInfo))]
        [EmailAddress(ErrorMessageResourceName = nameof(InvalidEmailAddress), ErrorMessageResourceType = typeof(RegistrationInfo))]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Display(Name = nameof(PasswordCaption), ResourceType = typeof(RegistrationInfo))]
        [Required(ErrorMessageResourceName = nameof(Required), ErrorMessageResourceType = typeof(RegistrationInfo))]
        [PasswordMinLength(ErrorMessageResourceName = nameof(MinimumPasswordLength), ErrorMessageResourceType = typeof(RegistrationInfo))]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = nameof(ConfirmPasswordCaption), ResourceType = typeof(RegistrationInfo))]
        [DataType(DataType.Password)]
        [Compare(nameof(Password), ErrorMessageResourceName = nameof(ConfirmPasswordMismatch), ErrorMessageResourceType = typeof(RegistrationInfo))]
        public string ConfirmPassword { get; set; }

        [Display(Name = nameof(FirstNameCaption), ResourceType = typeof(RegistrationInfo))]
        [Required(ErrorMessageResourceName = nameof(Required), ErrorMessageResourceType = typeof(RegistrationInfo))]
        [DataType(DataType.Text)]
        public string FirstName { get; set; }

        [Display(Name = nameof(LastNameCaption), ResourceType = typeof(RegistrationInfo))]
        [Required(ErrorMessageResourceName = nameof(Required), ErrorMessageResourceType = typeof(RegistrationInfo))]
        [DataType(DataType.Text)]
        public string LastName { get; set; }

        public static string ConfirmPasswordCaption => DictionaryPhraseRepository.Current.Get("/Accounts/Register/Confirm Password", "Confirm password");
        public static string EmailCaption => DictionaryPhraseRepository.Current.Get("/Accounts/Register/Email", "E-mail");
        public static string PasswordCaption => DictionaryPhraseRepository.Current.Get("/Accounts/Register/Password", "Password");
        public static string FirstNameCaption => DictionaryPhraseRepository.Current.Get("/Accounts/Register/First Name", "First Name");
        public static string LastNameCaption => DictionaryPhraseRepository.Current.Get("/Accounts/Register/Last Name", "Last Name");
        public static string ConfirmPasswordMismatch => DictionaryPhraseRepository.Current.Get("/Accounts/Register/Confirm Password Mismatch", "Your password confirmation does not match. Please enter a new password.");
        public static string MinimumPasswordLength => DictionaryPhraseRepository.Current.Get("/Accounts/Register/Minimum Password Length", "Please enter a password with at lease {1} characters");
        public static string Required => DictionaryPhraseRepository.Current.Get("/Accounts/Register/Required", "Please enter a value for {0}");
        public static string InvalidEmailAddress => DictionaryPhraseRepository.Current.Get("/Accounts/Register/Invalid Email Address", "Please enter a valid email address");
    }
}