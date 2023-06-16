import React, { useState } from 'react'
import UseFetch from '../UseFetch'
import { post } from '../Post'

const TimeList = () => {
    const timeTitle = "New Time"
    const [data] = UseFetch('https://localhost:7233/api/Time')
    const [showNewTime, setShowNewTime] = useState(false)
    const [distance, setDistance] = useState(0)
    const [time, setTime] = useState(0)

    const handleShowNewTime = () => {
        setShowNewTime(!showNewTime)
    }

    const handleDistanceChanged = (event) => {
        setDistance(event.target.value)
    }

    const handleTimeChanged = (event) => {
        setTime(event.target.value)
    }

    const handleSave = async () => {
        const data = {
            rundistance: parseInt(distance),
            totalTime: time,
            userId: 1,
        }
        console.log('sending data to server: ', data)
        const response = await post('https://localhost:7233/api/Time', data)
        console.log('yay! success, response from server', response)
    }

    const handleCancel = () => {
        setDistance(0)
        setTime(0)
        setShowNewTime(false)
    }

    return (
        <div className='text-center'>
            <button type="button" onClick={handleShowNewTime}>
                {timeTitle}
            </button>
            {showNewTime && (
                <div>
                    <div className='mt-5 flex justify-center items-center'>
                        <label>Distance: </label>
                        <input className='border-slate-300 border'
                            type="number" placeholder='enter distance'
                            onChange={handleDistanceChanged}
                            value={distance}
                        />km
                    </div>
                    <div className='mt-5'>
                        <label>Time: </label>
                        <input className='border-slate-300 border'
                            type="number" placeholder='enter time'
                            onChange={handleTimeChanged}
                            value={time}
                        />min
                    </div>
                    <div className='space-x-4 mt-5'>
                        <button className='bg-blue-500 hover:bg-blue-700 text-white py-1 px-2 rounded-lg' type="button" onClick={handleSave}>
                            Save
                        </button>
                        <button className='bg-red-500 hover:bg-red-700 text-white py-1 px-2 rounded-lg' type="button" onClick={handleCancel}>
                            Cancel
                        </button>
                    </div>
                </div>
            )}
            {data.map((time) => (
                <div key={time.id}>
                    <span>{time.rundistance}</span>
                    <span>{time.totalTime}</span>
                    <span>{time.userId}</span>
                </div>
            ))}
        </div>
    )
}

export default TimeList
