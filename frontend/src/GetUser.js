import UseFetch from './UseFetch'

const GetUser = () => {
    const [data] = UseFetch(
        'https://localhost:7233/api/User'
    )

    return (
        <div>
            {data.map((user) => (
                <div key={user.id}>
                    {' '}
                    {user.userName} {user.firstName}
                    {user.lastName}
                    {user.age}
                    {user.email}
                </div>
            ))}
        </div>
    )}


export default GetUser
