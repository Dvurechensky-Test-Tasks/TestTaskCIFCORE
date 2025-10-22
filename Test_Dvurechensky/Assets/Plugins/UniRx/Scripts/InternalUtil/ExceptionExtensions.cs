/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 22 октября 2025 13:45:11
 * Version: 1.0.62
 */

namespace UniRx.InternalUtil
{
	using System;

	internal static class ExceptionExtensions
	{
		public static void Throw(this Exception exception)
		{
#if (NET_4_6 || NET_STANDARD_2_0)
			System.Runtime.ExceptionServices.ExceptionDispatchInfo.Capture(exception).Throw();
#endif
            throw exception;
		}
	}
}
