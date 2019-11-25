export default function SingleSkillActivityPlans(activityplans) {
    return `
        ${activityplans.map( activityPlan => {
            return `
            <div class="activityDetails" id="activityDetail">
                <input class="activities_id" type="hidden" value="${activityPlan.id}">
                <h3>${activityPlan.description}</h3>
            </div> 
            `
        })
        }
    `
}