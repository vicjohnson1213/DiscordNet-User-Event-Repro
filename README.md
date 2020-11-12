# Discord.Net User Event Reproduction

**Update:** It was due to Discord intents. Head to dicord and check the "Server Members Intent" checkbox.

This is a reproduction of an issue I've run into where a few user related events aren't triggering. Many events seem to be firing just fine though and I've triple checked that the bots I'm using have Administrator rights in the servers I've tested in.

Versions I've tried:

- 2.2.0
- 2.3.0-dev-20200801.4
- 2.3.0-dev-20201109.3

The events that aren't working:

- `client.UserJoined`
- `client.UserLeft`
- `client.UserChanged`
- `client.GuildMemberUpdated`

The events that work fine:

- `client.ChannelCreated`
- `client.ChannelDestroyed`
- `client.MessageReceived`
