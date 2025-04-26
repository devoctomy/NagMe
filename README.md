# NagMe

Personal reminder assistant with added AI features.

## Introduction

NagMe is a small dotnet 8 WinForms application that can be configured to regularly remind you of things whilst you are spending all day infront of your computer.

Example of such reminders that you may configure using NagMe,

* **Activity Reminder** : Reminding you to take a break from sitting down for long periods and stretch your legs, walk about for a bit, get a drink. Sitting in front of your computer for extended periods of time without any breaks, will catch up on you eventually, it's a matter of 'when' not 'if'.

* **Eye Strain Break** : Reminder to follow the 20-20-20 rule to help reduce eye strain. https://www.medicalnewstoday.com/articles/321536

* **Posture Reminder** : Remind yourself routinely to stop slouching and sit correctly.

You aren't limited in what you choose to be reminded about, it's entirely up to you.

## Requirements

NagMe is currently restricted to only **Windows** computers due to using WinForms. I am considering changing to Avalonia to make it compatible Windows, Mac and Linux but that is a way off right now.

## AI Features

In an attempt to make things more interesting and engaging, I am integrating several AI features into NagMe

* AI Generated alert titles and messages
* AI Generated alert images
* AI Generated alert narration

These are only very basic features for now, but I am hoping they will make use of the app more enganging and less irritating when being reminded to do things you know you *should* do but regularly avoid.

## Creating a release

In order to create a release, complete with release notes, do the following.

1. Create a release notes file with the name of the version in the ReleaseNotes folder.
2. Commit and push the release notes
2. Create a push a tag for the version

```
git tag v0.2.0
git push origin --tags
```

> The tag should get picked up and the release workflow should get run.
