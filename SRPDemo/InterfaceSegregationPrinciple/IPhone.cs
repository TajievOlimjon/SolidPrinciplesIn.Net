using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRPDemo.InterfaceSegregationPrinciple
{
    public interface ICall
    {
        void Call();
    }
    public interface IPhoto
    {
        void TakePhoto();
    }
    public interface IVideo
    {
        void MakeVideo();
    }
    public interface IWeb
    {
        void BrowseInternet();
    }
    public class Phone : IPhoto,ICall,IVideo,IWeb
    {
        public void BrowseInternet()
        {
            Console.WriteLine("Мы в интернете , у нас интерент супер работает без отказа !!!");
        }

        public void Call()
        {
            Console.WriteLine("Мы звоним");
        }

        public void MakeVideo()
        {
            Console.WriteLine("Мы снимаем видео для рекламы");
        }

        public void TakePhoto()
        {
            Console.WriteLine("Мы фотографируем");
        }
    }
    public class Camera : IPhoto
    {
        public void TakePhoto()
        {
            Console.WriteLine("Мы фотографируем вас не убегайте");
        }
    }
    public class Photograph
    {
        public void TakePhoto(IPhoto phone)
        {
            phone.TakePhoto();
        }
    }
}
