// See https://aka.ms/new-console-template for more information
using dotenv.net;
using ViewTasker;

DotEnv.Load();

TaskerView view = new();

view.Menu();