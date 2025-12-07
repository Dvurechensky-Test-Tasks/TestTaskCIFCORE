/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 07 декабря 2025 12:55:31
 * Version: 1.0.108
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
