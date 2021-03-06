﻿using Moq;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace AgtechEConnect.Tests.Extensions
{
	public static class MockDbSetExtensions
	{
		public static void SetSource<T>(this Mock<DbSet<T>> mockDbSet, IList<T> source) where T : class
		{
			var data = source.AsQueryable();

			var mockSet = new Mock<DbSet<T>>();
			mockSet.As<IQueryable<T>>().Setup(m => m.Provider).Returns(data.Provider);
			mockSet.As<IQueryable<T>>().Setup(m => m.Expression).Returns(data.Expression);
			mockSet.As<IQueryable<T>>().Setup(m => m.ElementType).Returns(data.ElementType);
			mockSet.As<IQueryable<T>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());
		}
	}
}