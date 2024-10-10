# Модель прецедентів

## Загальна діаграма прецедентів

**На рис. 1 зображена загальна діаграма прецедентів та їх основні можливості.**

<center style="
    border-radius:4px;
    border: 1px solid #cfd7e6;
    box-shadow: 0 1px 3px 0 rgba(89,105,129,.05), 0 1px 1px 0 rgba(0,0,0,.025);
    padding: 1em;"
>

@startuml

    

@enduml

**Рис. 1** Загальна діаграма прецедентів

</center>

## Діаграма використання для Гостя

**На рис. 2 зображені усі можливості гостя.**

<center style="
    border-radius:4px;
    border: 1px solid #cfd7e6;
    box-shadow: 0 1px 3px 0 rgba(89,105,129,.05), 0 1px 1px 0 rgba(0,0,0,.025);
    padding: 1em;"
>

@startuml

actor "Гість" as Guest

usecase "<b>Log in</b>\nЗареєструвати обліковий запис" as UC_1
usecase "<b>Sign in</b>\nУвійти в обліковий запис" as UC_2

Guest -d-> UC_1
Guest -d-> UC_2

@enduml

**Рис. 2** Діаграма можливостей гостя  

</center>

## Діаграма використання для Користувача

**На рис. 3 зображені усі можливості користувача.**

<center style="
    border-radius:4px;
    border: 1px solid #cfd7e6;
    box-shadow: 0 1px 3px 0 rgba(89,105,129,.05), 0 1px 1px 0 rgba(0,0,0,.025);
    padding: 1em;"
>

@startuml

actor "Користувач" as User #lightblue

usecase "<b>Media content system</b>\nСистема медіа-контенту" as UC_1

usecase "<b>ContentCreate</b>\nСтворення медіа-контенту" as UC_1_1 #lightblue
usecase "<b>ContentSearch</b>\nПошук медіа-контенту" as UC_1_2 #lightblue
usecase "<b>ContentUpdate</b>\nРедагування інформації про медіа-контент" as UC_1_3 #lightblue
usecase "<b>ContentDelete</b>\nВидалення медіа-контенту" as UC_1_4 #lightblue

User -d-> UC_1

UC_1_1 .r.> UC_1: extends
UC_1_2 .u.> UC_1: extends
UC_1_3 .u.> UC_1: extends
UC_1_4 .l.> UC_1: extends

@enduml

**Рис. 3** Діаграма можливостей користувача

</center>

## Діаграма використання для Технічного експерта

**На рис. 4 зображені усі можливості технічного експерта.**

<center style="
    border-radius:4px;
    border: 1px solid #cfd7e6;
    box-shadow: 0 1px 3px 0 rgba(89,105,129,.05), 0 1px 1px 0 rgba(0,0,0,.025);
    padding: 1em;"
>

@startuml

actor "Технічний експерт" as TechnicalExpert #lightyellow

usecase "<b>User management</b>\nКерування користувачами" as UserManagement 

usecase "<b>DeleteUser</b>\nВидалення користувача" as DeleteUser #lightblue
usecase "<b>UserRolePromote</b>\nПідвищення ролі користувача" as UserRolePromote #lightblue

TechnicalExpert --> UserManagement

DeleteUser .u.> UserManagement : "extends"
UserRolePromote .u.> UserManagement : "extends"    

@enduml

**Рис. 4** Діаграма можливостей технічного експерта

</center>
