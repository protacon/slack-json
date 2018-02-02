[![Build Status](https://jenkins.protacon.cloud/buildStatus/icon?job=www.github.com/slack-integration/master)](https://jenkins.protacon.cloud/job/www.github.com/job/slack-integration/job/master/)

# slack-integration
Integration part that integrates slack to github based on configuration file at repository.

# Setup
Deploy integration to public web address.

Setup global webhook for address `todo`.

# slack.json format
Add file `slack.json` to repository root folder.

```json
{
    "version": "1",
    "channels": ["#general", "#labs"],
    "notify": ["pull-request"]
}
```
