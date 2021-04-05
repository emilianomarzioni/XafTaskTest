;#DropDB XafTaskTestEasyTest

#Application XafTaskTestWin
#Application XafTaskTestWeb

*FillForm
 User Name = Admin
*Action Log In

#IfDef XafTaskTestWin

*Action About...
 
*Action OK

#EndIf

#IfDef XafTaskTestWeb
*Action Navigation(My Details)
#EndIf
