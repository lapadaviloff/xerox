using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xerox
{
    /// <summary>
    /// Интерфейс отправки изображения
    /// </summary>
    interface IOutputImage
    {
        /// <summary>
        ///Отправка изображения
        /// </summary>
        void send();
    }
}
