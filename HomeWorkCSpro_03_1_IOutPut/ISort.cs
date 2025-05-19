using System;

namespace HomeWorkCSpro_03_1_IOutPut_2_IMath
{
    public interface ISort
    {
        void SortAsc();
        void SortDesc();
        void SortByParam(bool isAsc);
    }
}
