Imports DiscordRPC

Namespace DiscordRPCHandler
    Public Class InitRPC
        Public Shared Property Client As DiscordRpcClient

        Public Shared Sub Setup(ByVal id As Int64, ByVal details As String, ByVal state As String)
            Client = New DiscordRpcClient(id)
            Client.Initialize()
            Client.SetPresence(New RichPresence() With {
                .Details = details,
                .State = state,
                .Assets = New Assets() With {
                    .LargeImageKey = "discord_rcp",
                    .LargeImageText = "Creating Battle Teams!"
                }
            })
        End Sub
    End Class

    Public Class Disp
        Public Shared Property Client As DiscordRpcClient

        Sub Dispose()
            Client = New DiscordRpcClient("861016966855786516")
            Client.Initialize()
            Client.Dispose()
        End Sub
    End Class
End Namespace
