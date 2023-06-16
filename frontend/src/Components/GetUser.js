import UseFetch from '../UseFetch'

const GetUser = () => {
    const [data] = UseFetch('https://localhost:7233/api/User')

    return (
        <div className="get-user">
            {data.map((user) => (
                <div key={user.id}>
                    <ul className="list-of-data">
                        <li>
                            {user.userName} {user.firstName} {user.lastName}{' '}
                            {user.age} {user.email}
                        </li>
                    </ul>
                </div>
            ))}
        </div>
    )
}

export default GetUser
