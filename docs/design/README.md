# Проєктування бази даних

## Модель бізнес-об'єктів

@startuml

left to right direction


entity User <<ENTITY>> #900020
entity User.id <<NUMBER>> #C41E3A
entity User.first_name <<TEXT>> #C41E3A
entity User.last_name <<TEXT>> #C41E3A
entity User.email <<TEXT>> #C41E3A
entity User.password <<TEXT>> #C41E3A

User.id --* User
User.first_name --* User
User.last_name --* User
User.email --* User
User.password --* User


entity MediaContent <<ENTITY>> #990099
entity MediaContent.id <<NUMBER>> #CC00CC
entity MediaContent.title <<TEXT>> #CC00CC
entity MediaContent.description <<TEXT>> #CC00CC
entity MediaContent.body <<TEXT>> #CC00CC
entity MediaContent.content_type <<TEXT>> #CC00CC
entity MediaContent.created_at <<DATE>> #CC00CC
entity MediaContent.updated_at <<DATE>> #CC00CC

MediaContent.id --* MediaContent
MediaContent.title --* MediaContent
MediaContent.description --* MediaContent
MediaContent.body --* MediaContent
MediaContent.content_type --* MediaContent
MediaContent.created_at --* MediaContent
MediaContent.updated_at --* MediaContent

entity Role <<ENTITY>> #FFFF00
entity Role.id <<NUMBER>> #FFFF66
entity Role.name <<TEXT>> #FFFF66
entity Role.description <<TEXT>> #FFFF66

Role.id --* Role
Role.name --* Role
Role.description --* Role


entity Permission <<ENTITY>> #606060
entity Permission.id <<NUMBER>> #A0A0A0
entity Permission.name <<TEXT>> #A0A0A0

Permission.id -u-* Permission
Permission.name -u-* Permission


entity Source <<ENTITY>> #FF6500
entity Source.id <<NUMBER>> #FFBD73
entity Source.name <<TEXT>> #FFBD73
entity Source.url <<TEXT>> #FFBD73

Source.id --* Source 
Source.name --* Source 
Source.url --* Source


entity AnalysisResult <<ENTITY>> #80FF00
entity AnalysisResult.id <<NUMBER>> #B2FF66
entity AnalysisResult.created_at <<DATE>> #B2FF66
entity AnalysisResult.title <<TEXT>> #B2FF66
entity AnalysisResult.description <<TEXT>> #B2FF66
entity AnalysisResult.body <<TEXT>> #B2FF66

AnalysisResult.id --* AnalysisResult
AnalysisResult.created_at --* AnalysisResult
AnalysisResult.title --* AnalysisResult
AnalysisResult.description --* AnalysisResult
AnalysisResult.body --* AnalysisResult


entity Tag <<ENTITY>> #08C2FF 
entity Tag.name <<TEXT>> #BCF2F6 
entity Tag.id <<NUMBER>> #BCF2F6

Tag.id --* Tag 
Tag.name --* Tag


entity RolePermission <<ENTITY>>

entity MediaContentSource <<ENTITY>>

entity MediaContentAnalysisResult <<ENTITY>>

entity MediaContentTag <<ENTITY>>

entity AnalysisResultTag <<ENTITY>>

entity SourceTag <<ENTITY>>


User "1.1" -- "0.*" MediaContent
User "1.1" -- "0.*" AnalysisResult
User "1.*" -- "1.1" Role

Role "1.1" -- "0.*" RolePermission
RolePermission "1.*" -- "1.1" Permission

MediaContent "1.1" -- "0.*" MediaContentSource
MediaContentSource "1.*" -- "1.1" Source

MediaContent "1.1" -- "0.*" MediaContentAnalysisResult
MediaContentAnalysisResult "1.*" -- "1.1" AnalysisResult

MediaContent "1.1" -- "0.*" MediaContentTag
MediaContentTag "1.*" -- "1.1" Tag

AnalysisResult "1.1" -- "0.*" AnalysisResultTag
AnalysisResultTag "1.*" -- "1.1" Tag

Source "1.1" -- "0.*" SourceTag
SourceTag "1.*" -- "1.1" Tag

@enduml

- ER-модель
- реляційна схема

