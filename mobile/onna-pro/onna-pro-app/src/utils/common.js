export const getRoomId = (userId1, userId2) => {
    const sortedIds = [userId1, userId2].sort()
    const roomId = sortedIds.join("-")
    return roomId
}

export const formatDate = date => {
    var day = date.getDate()
    var monthNames = ["Jan", "Feb", "Mar", "Abr", "Mai", "Jun", "Jul", "Ago", "Set", "Out", "Nov", "Dez"]
    var month = monthNames[date.getMonth()]

    var formattedDate = day + " " + month
    return formattedDate
}