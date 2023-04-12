import UseFetch from './UseFetch'

const TimeRow = (props) => {
    const { time } = props
    return (
        <div className='time-row' >
            <ul>
                <li>
                    {time.rundistance} {time.totalTime}
                </li>
            </ul>
        </div>
    )
}
const TimeList = () => {
    const [data] = UseFetch('https://localhost:7233/api/Time')

    return (
        <div className="time-list">
            {data.map((row) => (
                <TimeRow time={row} key={row.id}/>
            ))}
        </div>
    )
}

export default TimeList
