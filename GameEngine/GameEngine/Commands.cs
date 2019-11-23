using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine
{
    // Command pattern.
    interface IUI
    {
        void moveUp();
        void moveLeft();
        void moveRight();
        void moveDown();
        void Select();

    }

    class MenuCommands : IUI
    {
        public void Select()
        {
            Console.WriteLine("Select");
        }

        public void moveDown()
        {
            Console.WriteLine("Move down.");
        }

        public void moveLeft()
        {
            Console.WriteLine("Move left.");
        }

        public void moveRight()
        {
            Console.WriteLine("Move right.");
        }

        public void moveUp()
        {
            Console.WriteLine("Move up.");
        }
    }

    class PlayerCommands : IUI
    {
        public void Select()
        {
            Console.WriteLine("Action.");
        }

        public void moveDown()
        {
            Console.WriteLine("Crawl.");
        }

        public void moveLeft()
        {
            Console.WriteLine("Go left.");
        }

        public void moveRight()
        {
            Console.WriteLine("Go right.");
        }

        public void moveUp()
        {
            Console.WriteLine("Jump.");
        }
    }

    interface ICommand
    {
        void execute();
    }

    class Up : ICommand
    {
        private IUI uInterface = null;
        
        public Up(IUI uInterface)
        {
            uInterface = this.uInterface;
        }

        public void execute()
        {
            uInterface.moveUp();
        }

    }

    class Left : ICommand
    {
        private IUI uInterface = null;

        public Left(IUI uInterface)
        {
            uInterface = this.uInterface;
        }

        public void execute()
        {
            uInterface.moveLeft();
        }

    }


    class Right : ICommand
    {
        private IUI uInterface = null;

        public Right(IUI uInterface)
        {
            uInterface = this.uInterface;
        }

        public void execute()
        {
            uInterface.moveRight();
        }

    }

    class Down : ICommand
    {
        private IUI uInterface = null;

        public Down(IUI uInterface)
        {
            uInterface = this.uInterface;
        }

        public void execute()
        {
            uInterface.moveDown();
        }

    }

    class Select : ICommand
    {
        private IUI uInterface = null;

        public Select(IUI uInterface)
        {
            uInterface = this.uInterface;
        }

        public void execute()
        {
            uInterface.Select();
        }

    }


}
