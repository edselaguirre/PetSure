var Controller = function ($scope, $http) {

    var api_petinfo = 'http://localhost:8888/api/PetInfo';
    var data = this;


    $scope.getPetInfo = function () {
        $http({
            url: api_petinfo
        })
            .then(function onSuccess(response) {
                data.PetInfoList = response.data.petinfo;
                $scope.defaulPetInfo = response.data.defPetInfo;
                console.log('data = ' + response.data.petinfo);
            });
    }

    $scope.getPetInfo();
    console.log('test');
}