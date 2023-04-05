import UseFetch from "./UseFetch";

const GetTime = () => {

    const [data] = UseFetch('https://localhost:7233/api/Time')
    return (
        <div>
            {data.map((time) =>
            (
                <div key={time.id}> {time.rundistance} {time.totalTime}</div>
            ))}
        </div>
      );
}
 
export default GetTime;