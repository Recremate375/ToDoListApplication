﻿namespace ToDoListClientSide.Model
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public List<MyTask>? Tasks { get; set; }
    }
}
