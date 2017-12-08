﻿namespace ETicketSystem.Services.Contracts
{
	using ETicketSystem.Services.Models.Route;
	using System;
	using System.Collections.Generic;

	public interface IRouteService
    {
		IEnumerable<RouteSearchListingServiceModel> GetSearchedRoutes(int startTown, int endTown, DateTime date);
    }
}