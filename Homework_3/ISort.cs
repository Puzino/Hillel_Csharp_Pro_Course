using System;
namespace Homework_3
{
	public interface ISort
	{
		public void SortAsc(); // — сортування за зростанням; 
        public void SortDesc(); // — сортування за зменшенням;
		public void SortByParam(bool isAsc); // — сортування залежно від переданого параметра.

    }
}

