# Manager ActiveDirectory [![Official Site](https://img.shields.io/badge/site-servodroid.com-orange.svg)](http://servodroid.com)

Parsing all sentenses with vocabulary and times. XML file with almost french words. You can add your own database to have your words.

[![License](https://img.shields.io/github/license/brandondahler/Data.HashFunction.svg)](https://raw.githubusercontent.com/ThibaultMontaufray/Tools4Libraries/master/License) [![Version Status](https://img.shields.io/nuget/v/Droid_ActiveDirectory.svg)](https://www.nuget.org/packages/Droid_ActiveDirectory/)    [![Build Status](https://travis-ci.org/ThibaultMontaufray/Manager-ActiveDirectory.svg?branch=master)](https://travis-ci.org/ThibaultMontaufray/Manager-ActiveDirectory)  [![Coverage Status](https://coveralls.io/repos/github/ThibaultMontaufray/Manager-ActiveDirectory/badge.svg?branch=master)](https://coveralls.io/github/ThibaultMontaufray/Manager-ActiveDirectory?branch=master)  [![Jenkins test](https://img.shields.io/jenkins/t/http/servodroid.com:8080/CI-Manager-ActiveDirectory.svg)](http://servodroid.com:8080/job/CI-Manager-ActiveDirectory/) 

# Usage

```csharp
Enterprise ent = new Enterprise();
ent.Login = _textBoxLogin.Text;
ent.Password = _textBoxPwd.Text;
List _users = _enterprise.Users;
```
