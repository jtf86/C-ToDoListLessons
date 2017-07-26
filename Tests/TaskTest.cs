using Xunit;
using System.Collections.Generic;
using System;

namespace ToDoList.Objects
{
    public class ToDoListTest : IDisposable
    {
        public void Dispose()
        {
          Task.ClearAll();
        }
        [Fact]
        public void GetDescription_ReturnsDescription_String()
        {
          //Arrange
          string description = "Walk the dog.";
          Task newTask = new Task(description);

          //Act
          string result = newTask.GetDescription();

          //Assert
          Assert.Equal(description, result);
        }

        [Fact]
        public void GetZAll_ReturnsTasks_TaskList()
        {
          //Arrange
          string description01 = "Walk the dog";
          string description02 = "Wash the dishes";
          Task newTask1 = new Task(description01);
          Task newTask2 = new Task(description02);
          List<Task> newList = new List<Task> { newTask1, newTask2 };

          //Act
          List<Task> result = Task.GetAll();

          //Assert
          Assert.Equal(newList, result);
        }

    }
}
