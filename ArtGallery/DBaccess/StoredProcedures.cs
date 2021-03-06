﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArtGallery.DBaccess
{
    public class StoredProcedures
    {
        public static string SignIn = "SignIn";
        public static string AddAdmin = "AddAdmin";
        public static string SignInAdmin = "SignInAdmin";
        public static string OldRating = "OldRating";
        public static string InsertRating = "InsertRating";
        public static string GetAdminID = "GetAdminID";
        public static string SignUp = "SignUp";
        
        public static string InsertExpert = "ADD_EXPERT";
        public static string InsertArtist = "InsertArtist";
        public static string InsertQualifications = "AddQualifications";
        public static string InsertArtwork = "InsertArtwork";
        public static string InsertSurveyRequest = "InsertSurveyRequest";
        public static string InsertBillingInfo = "InsertBillingInfo";
        public static string CreateEvent = "CreateEvent";
        public static string Addcompany = "Addcompany";

        public static string EmailAvailable = "EmailAvailable";
        public static string ProfileImagePath = "ProfileImagePath";
        public static string UserName_BY_EMAIL = "UserName_BY_EMAIL";
        public static string UserNameAvailable = "UserNameAvailable";
        public static string IsArtist = "IsArtist";
        public static string IsExpert = "IsExpert";
        public static string UpdatePassword = "UpdatePassword";

        public static string GetArtist = "GetArtist";
        public static string GetArtworkInfo = "GetArtworkInfo";
        public static string GetArtworks = "GetArtworks";
        public static string GetEmail = "GetEmail";
        public static string GetExpert = "GetExpert";
        public static string GetExperts = "GetExperts";
        public static string GetExpertMails = "GetExpertMails";
        public static string GetOrderById = "GetOrderById";
        public static string GetReportById = "GetReportById";
        public static string GetSortedOrders = "GetSortedOrders";
        public static string GetSortedReports = "GetSortedReports";
        public static string GetPassword = "GetPassword";
        public static string GetSortedProposedArtworks = "GetSortedProposedArtworks";
        public static string GetProposedArtworksByArtist = "GetProposedArtworksByArtist";
        public static string GetEventInfo = "GetEventInfo";
        public static string GetEvents = "GetEvents";
        public static string GetArtWorksByArtist = "GetArtWorksByArtist";
        public static string GetCategories = "GetCategories";
        public static string GetRequestedSurvey = "GetRequestedSurvey";
        public static string GetSurveyInfo = "GetSurveyInfo";
        public static string GetArtworkWithCode = "GetArtworkWithCode";
        public static string GetArtists = "GetArtists";
        public static string GetCompanies = "GetCompanies";
        public static string GetOrderInfo = "GetOrderInfo";
        public static string GetFavourite = "GetFavourite";

        public static string SellTicket = "SellTicket";
        public static string EditEvent = "EditEvent";
        public static string InviteArtist = "InviteArtist";
        public static string AttendUserEvent = "AttendUserEvent";

        public static string ApproveArtwork = "ApproveArtwork";

        public static string deleteCompany = "deleteCompany";

        public static string addFav = "addFav";
        public static string RecommendAW = "RecommendAW";
        public static string GetArtworksforrecommanded = "GetArtworksforrecommanded";
      
        public static string GetRecommended = "GetRecommended ";
        public static string GetUserSurveys = "GetUserSurveys";
        public static string ArtistSalaryLess = "ArtistSalaryLess";
        public static string InsertCustomOrder = "InsertCustomOrder";
        public static string SolveReport = "SolveReport";
        public static string UpdateOrder = "UpdateOrder";
        public static string UpdateOrderInfo = "UpdateOrderInfo";


        //statistics

        public static string NumAttendEvent = "NumAttendEvent ";
        public static string NumOrderShipped = "NumOrderShipped";
        public static string NumArtwrkCategory = "NumArtwrkCategory";
        public static string NumSurvExp = "NumSurvExp";
        public static string NumUsers = "NumUsers";
        public static string NumArtists = "NumArtists";
        public static string NumExperts = "NumExperts";
        public static string EventsRevenue = "EventsRevenue";
        public static string CATEGORY_PRICE = "CATEGORY_PRICE";
        public static string NumInvitedArtist = "NumInvitedArtist";




    }
}
