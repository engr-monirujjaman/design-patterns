
using MementoPattern;

var editor = new Editor();

editor.SetText("Text - 1");
editor.Save();

editor.SetText("Text - 2");
editor.Save();
editor.SetText("Text - 3");
editor.Save();

Console.WriteLine(editor);

editor.Undo();
editor.Undo();
editor.Undo();

Console.WriteLine(editor);